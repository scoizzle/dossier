# Fact 93de1212

Store id: 0aa3a7fa-1f2d-4b63-9874-a4cdc14dac35

## Text

```text
def from_param(cls, context, param)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.6665130+00:00`

## Data

```json
{
  "end_line": 1544,
  "entity_kind": "class_method",
  "parent": "OrderByList",
  "start_line": 1531,
  "symbol": "OrderByList.from_param"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1531,"selector":"L1531-L1544","symbol":"OrderByList.from_param"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OrderByList.from_param](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1544,
    "entity_kind": "class_method",
    "parent": "OrderByList",
    "start_line": 1531,
    "symbol": "OrderByList.from_param"
  },
  "id": "0aa3a7fa-1f2d-4b63-9874-a4cdc14dac35",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6665130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1531,
        "selector": "L1531-L1544",
        "symbol": "OrderByList.from_param"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "478be555-fa3c-44b3-98ee-054654b4704e",
  "subject_name": "django/db/models/expressions::OrderByList.from_param",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def from_param(cls, context, param)"
}
```
