# Fact ceb86571

Store id: 1f0a5693-57bc-4c59-8bb5-d773c699093b

## Text

```text
def _prefetch_related_objects(self)
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
- posted_at: `2026-11-09T23:44:56.0015620+00:00`

## Data

```json
{
  "end_line": 1516,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1513,
  "symbol": "QuerySet._prefetch_related_objects"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1513,"selector":"L1513-L1516","symbol":"QuerySet._prefetch_related_objects"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._prefetch_related_objects](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1516,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1513,
    "symbol": "QuerySet._prefetch_related_objects"
  },
  "id": "1f0a5693-57bc-4c59-8bb5-d773c699093b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.0015620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1513,
        "selector": "L1513-L1516",
        "symbol": "QuerySet._prefetch_related_objects"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "4d57efdb-2ccb-450c-94ca-c1fd3e464b2a",
  "subject_name": "django/db/models/query::QuerySet._prefetch_related_objects",
  "tags": [
    "entity:method"
  ],
  "text": "def _prefetch_related_objects(self)"
}
```
