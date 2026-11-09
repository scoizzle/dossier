# Fact cdd45e6d

Store id: 33985db8-dc00-4b68-bb5b-2933d42b7d57

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T23:32:04.7582510+00:00`

## Data

```json
{
  "end_line": 2517,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2516,
  "symbol": "RawQuerySet.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2516,"selector":"L2516-L2517","symbol":"RawQuerySet.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2517,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2516,
    "symbol": "RawQuerySet.__repr__"
  },
  "id": "33985db8-dc00-4b68-bb5b-2933d42b7d57",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.7582510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2516,
        "selector": "L2516-L2517",
        "symbol": "RawQuerySet.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "0ae18553-e898-46a6-ba8c-9bafee307197",
  "subject_name": "django/db/models/query::RawQuerySet.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
