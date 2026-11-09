# Fact be9f2c53

Store id: 9552cec2-0fa4-49ad-9ee4-fca14c2800fe

## Text

```text
def _fetch_all(self)
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
- posted_at: `2026-11-09T22:39:49.7880750+00:00`

## Data

```json
{
  "end_line": 2489,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2485,
  "symbol": "RawQuerySet._fetch_all"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2485,"selector":"L2485-L2489","symbol":"RawQuerySet._fetch_all"}`

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet._fetch_all](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2489,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2485,
    "symbol": "RawQuerySet._fetch_all"
  },
  "id": "9552cec2-0fa4-49ad-9ee4-fca14c2800fe",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.7880750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2485,
        "selector": "L2485-L2489",
        "symbol": "RawQuerySet._fetch_all"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "ccede265-e254-4128-a7e8-1f693b0e5014",
  "subject_name": "django/db/models/query::RawQuerySet._fetch_all",
  "tags": [
    "entity:method"
  ],
  "text": "def _fetch_all(self)"
}
```
