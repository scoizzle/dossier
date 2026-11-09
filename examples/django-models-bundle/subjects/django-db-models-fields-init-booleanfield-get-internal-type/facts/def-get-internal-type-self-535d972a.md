# Fact 535d972a

Store id: a6a43a42-87e3-48a4-9e91-150d033a065a

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
- posted_at: `2026-11-09T22:39:42.3665510+00:00`

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
  "id": "a6a43a42-87e3-48a4-9e91-150d033a065a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3665510+00:00"
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
  "subject_id": "ddc9ba98-7a7e-4773-8740-bfca15529909",
  "subject_name": "django/db/models/fields/__init__::BooleanField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
