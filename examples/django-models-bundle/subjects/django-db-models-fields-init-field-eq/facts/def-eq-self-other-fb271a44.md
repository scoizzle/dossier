# Fact fb271a44

Store id: 02bfc681-8d9b-4a6e-9475-4c20f24ff11f

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
- posted_at: `2026-11-09T23:44:49.9937730+00:00`

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
  "id": "02bfc681-8d9b-4a6e-9475-4c20f24ff11f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.9937730+00:00"
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
  "subject_id": "34105f2f-098b-4b8d-a547-f5e803e856e9",
  "subject_name": "django/db/models/fields/__init__::Field.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
