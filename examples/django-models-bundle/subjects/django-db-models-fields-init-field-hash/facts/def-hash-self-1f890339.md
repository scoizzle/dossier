# Fact 1f890339

Store id: bc065492-bf05-443f-a5db-30ddb28272fb

## Text

```text
def __hash__(self)
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
- posted_at: `2026-11-09T22:39:42.3018050+00:00`

## Data

```json
{
  "end_line": 743,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 742,
  "symbol": "Field.__hash__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":742,"selector":"L742-L743","symbol":"Field.__hash__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.__hash__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 743,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 742,
    "symbol": "Field.__hash__"
  },
  "id": "bc065492-bf05-443f-a5db-30ddb28272fb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3018050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 742,
        "selector": "L742-L743",
        "symbol": "Field.__hash__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "59b52aeb-babf-463c-948a-27efa0a006d7",
  "subject_name": "django/db/models/fields/__init__::Field.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
