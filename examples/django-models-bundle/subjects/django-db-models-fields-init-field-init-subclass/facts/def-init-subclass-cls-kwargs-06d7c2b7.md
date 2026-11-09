# Fact 06d7c2b7

Store id: 056619c2-7616-4d25-a719-3e6ff4fe212b

## Text

```text
def __init_subclass__(cls, **kwargs)
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
- posted_at: `2026-11-09T23:31:56.4178250+00:00`

## Data

```json
{
  "end_line": 217,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 193,
  "symbol": "Field.__init_subclass__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":193,"selector":"L193-L217","symbol":"Field.__init_subclass__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.__init_subclass__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 217,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 193,
    "symbol": "Field.__init_subclass__"
  },
  "id": "056619c2-7616-4d25-a719-3e6ff4fe212b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4178250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 193,
        "selector": "L193-L217",
        "symbol": "Field.__init_subclass__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "bf1409f1-e041-4719-8de3-d2123879efb0",
  "subject_name": "django/db/models/fields/__init__::Field.__init_subclass__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init_subclass__(cls, **kwargs)"
}
```
