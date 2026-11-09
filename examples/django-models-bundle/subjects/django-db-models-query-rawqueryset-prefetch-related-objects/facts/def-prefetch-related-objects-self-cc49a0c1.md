# Fact cc49a0c1

Store id: 36efaeb6-382c-42c7-b03c-cafd98464950

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
- posted_at: `2026-11-09T23:44:56.2248940+00:00`

## Data

```json
{
  "end_line": 2469,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2467,
  "symbol": "RawQuerySet._prefetch_related_objects"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2467,"selector":"L2467-L2469","symbol":"RawQuerySet._prefetch_related_objects"}`

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet._prefetch_related_objects](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2469,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2467,
    "symbol": "RawQuerySet._prefetch_related_objects"
  },
  "id": "36efaeb6-382c-42c7-b03c-cafd98464950",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.2248940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2467,
        "selector": "L2467-L2469",
        "symbol": "RawQuerySet._prefetch_related_objects"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "eeca8fdf-8aad-4d7a-8acd-fca19ef943b2",
  "subject_name": "django/db/models/query::RawQuerySet._prefetch_related_objects",
  "tags": [
    "entity:method"
  ],
  "text": "def _prefetch_related_objects(self)"
}
```
