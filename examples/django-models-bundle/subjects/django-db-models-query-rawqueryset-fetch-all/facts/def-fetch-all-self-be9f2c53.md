# Fact be9f2c53

Store id: 748abf23-72e7-4eba-a4c5-ba674af218d2

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
- posted_at: `2026-11-09T23:44:56.2321370+00:00`

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
  "id": "748abf23-72e7-4eba-a4c5-ba674af218d2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.2321370+00:00"
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
  "subject_id": "82e05b0c-2f4f-473f-ae67-56874c7bce7e",
  "subject_name": "django/db/models/query::RawQuerySet._fetch_all",
  "tags": [
    "entity:method"
  ],
  "text": "def _fetch_all(self)"
}
```
