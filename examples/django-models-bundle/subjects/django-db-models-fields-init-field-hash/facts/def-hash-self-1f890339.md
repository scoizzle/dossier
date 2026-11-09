# Fact 1f890339

Store id: d05624c7-69ed-4ecc-b349-cac94c2a4ea2

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
- posted_at: `2026-11-09T23:31:56.4563540+00:00`

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
  "id": "d05624c7-69ed-4ecc-b349-cac94c2a4ea2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4563540+00:00"
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
  "subject_id": "d510c31b-7eab-4fea-9697-830a656a5f70",
  "subject_name": "django/db/models/fields/__init__::Field.__hash__",
  "tags": [
    "entity:method"
  ],
  "text": "def __hash__(self)"
}
```
