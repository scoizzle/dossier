# Fact c103db30

Store id: 5a8f7e60-38c0-44d7-8c66-10e27eb36e9c

## Text

```text
def _get_repr_options(self)
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
- posted_at: `2026-11-09T23:31:55.8533880+00:00`

## Data

```json
{
  "end_line": 1089,
  "entity_kind": "method",
  "parent": "Func",
  "start_line": 1087,
  "symbol": "Func._get_repr_options"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1087,"selector":"L1087-L1089","symbol":"Func._get_repr_options"}`

## Items

```json
[
  {
    "text": "Return a dict of extra __init__() options to include in the repr.",
    "locator": {
      "line": 1088
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::Func._get_repr_options](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1089,
    "entity_kind": "method",
    "parent": "Func",
    "start_line": 1087,
    "symbol": "Func._get_repr_options"
  },
  "id": "5a8f7e60-38c0-44d7-8c66-10e27eb36e9c",
  "items": [
    {
      "locator": {
        "line": 1088
      },
      "text": "Return a dict of extra __init__() options to include in the repr."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8533880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1087,
        "selector": "L1087-L1089",
        "symbol": "Func._get_repr_options"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "1e8ba4ac-0651-45f8-a35f-d23d25356173",
  "subject_name": "django/db/models/expressions::Func._get_repr_options",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_repr_options(self)"
}
```
