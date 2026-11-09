# Fact 535d972a

Store id: 02a93855-f4fc-4d77-834f-f0bc3221a3a2

## Text

```text
def get_internal_type(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:56.5388290+00:00`

## Data

```json
{
  "end_line": 1209,
  "entity_kind": "method",
  "parent": "BooleanField",
  "start_line": 1208,
  "symbol": "BooleanField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1208,"selector":"L1208-L1209","symbol":"BooleanField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BooleanField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1209,
    "entity_kind": "method",
    "parent": "BooleanField",
    "start_line": 1208,
    "symbol": "BooleanField.get_internal_type"
  },
  "id": "02a93855-f4fc-4d77-834f-f0bc3221a3a2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5388290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1208,
        "selector": "L1208-L1209",
        "symbol": "BooleanField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "b9438384-b121-46b0-bea3-af3c9a17165a",
  "subject_name": "django/db/models/fields/__init__::BooleanField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
