# Fact cdd45e6d

Store id: c6867007-19a9-4b75-85c1-987176de5551

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
- posted_at: `2026-11-09T22:39:49.8144680+00:00`

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
  "id": "c6867007-19a9-4b75-85c1-987176de5551",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.8144680+00:00"
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
  "subject_id": "b46b5a18-4f0c-4b07-badc-fc3029e2b802",
  "subject_name": "django/db/models/query::RawQuerySet.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
