# Fact 21f78cdd

Store id: 423d5b04-8d4d-4bdd-959d-b4a6eb33969f

## Text

```text
def __init__(self, lookup, queryset=None, to_attr=None)
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
- posted_at: `2026-11-09T22:39:49.8406540+00:00`

## Data

```json
{
  "end_line": 2592,
  "entity_kind": "method",
  "parent": "Prefetch",
  "start_line": 2571,
  "symbol": "Prefetch.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2571,"selector":"L2571-L2592","symbol":"Prefetch.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/query::Prefetch.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2592,
    "entity_kind": "method",
    "parent": "Prefetch",
    "start_line": 2571,
    "symbol": "Prefetch.__init__"
  },
  "id": "423d5b04-8d4d-4bdd-959d-b4a6eb33969f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.8406540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2571,
        "selector": "L2571-L2592",
        "symbol": "Prefetch.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "87746cd5-68da-4577-90a8-04989ea1908c",
  "subject_name": "django/db/models/query::Prefetch.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, lookup, queryset=None, to_attr=None)"
}
```
