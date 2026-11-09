# Fact 00060221

Store id: 34261f75-fa06-4697-8525-cc6f77fe1b24

## Text

```text
def __init__( self, raw_query, model=None, query=None, params=(), translations=None, using=None, hints=None, fetch_mode=DEFAULT_FETCH_MODE, )
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
- posted_at: `2026-11-09T22:39:49.7706060+00:00`

## Data

```json
{
  "end_line": 2437,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2416,
  "symbol": "RawQuerySet.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2416,"selector":"L2416-L2437","symbol":"RawQuerySet.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2437,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2416,
    "symbol": "RawQuerySet.__init__"
  },
  "id": "34261f75-fa06-4697-8525-cc6f77fe1b24",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.7706060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2416,
        "selector": "L2416-L2437",
        "symbol": "RawQuerySet.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "525eca33-d3f5-4dc5-aeb6-361960d102b2",
  "subject_name": "django/db/models/query::RawQuerySet.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__( self, raw_query, model=None, query=None, params=(), translations=None, using=None, hints=None, fetch_mode=DEFAULT_FETCH_MODE, )"
}
```
