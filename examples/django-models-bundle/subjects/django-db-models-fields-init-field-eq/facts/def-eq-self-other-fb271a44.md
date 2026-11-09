# Fact fb271a44

Store id: 0adf6c79-f1a7-4f13-b5b0-ef764105ab1b

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T23:31:56.4533550+00:00`

## Data

```json
{
  "end_line": 720,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 714,
  "symbol": "Field.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":714,"selector":"L714-L720","symbol":"Field.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 720,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 714,
    "symbol": "Field.__eq__"
  },
  "id": "0adf6c79-f1a7-4f13-b5b0-ef764105ab1b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4533550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 714,
        "selector": "L714-L720",
        "symbol": "Field.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "796259fd-fe81-476b-a4ff-39317ce5c56e",
  "subject_name": "django/db/models/fields/__init__::Field.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
