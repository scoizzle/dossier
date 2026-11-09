# Fact 1f890339

Store id: 8086a812-0fc0-447d-9ec6-7c23fa313052

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
- posted_at: `2026-11-09T23:44:49.9960340+00:00`

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
  "id": "8086a812-0fc0-447d-9ec6-7c23fa313052",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.9960340+00:00"
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
  "subject_id": "f3bcdaef-1acb-4bb3-903d-5472c187eaf3",
  "subject_name": "django/db/models/fields/__init__::Field.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
