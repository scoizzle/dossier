# Fact b3fc5546

Store id: eacc9993-d177-431a-bb3a-df7920666ca3

## Text

```text
def get_current_querysets(self, level)
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
- posted_at: `2026-11-09T22:39:49.8576790+00:00`

## Data

```json
{
  "end_line": 2623,
  "entity_kind": "method",
  "parent": "Prefetch",
  "start_line": 2617,
  "symbol": "Prefetch.get_current_querysets"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2617,"selector":"L2617-L2623","symbol":"Prefetch.get_current_querysets"}`

## Referenced by

None.

## Subject

[django/db/models/query::Prefetch.get_current_querysets](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2623,
    "entity_kind": "method",
    "parent": "Prefetch",
    "start_line": 2617,
    "symbol": "Prefetch.get_current_querysets"
  },
  "id": "eacc9993-d177-431a-bb3a-df7920666ca3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.8576790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2617,
        "selector": "L2617-L2623",
        "symbol": "Prefetch.get_current_querysets"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "e61e05e6-9db4-4c19-97a8-80743b6d882e",
  "subject_name": "django/db/models/query::Prefetch.get_current_querysets",
  "tags": [
    "entity:method"
  ],
  "text": "def get_current_querysets(self, level)"
}
```
