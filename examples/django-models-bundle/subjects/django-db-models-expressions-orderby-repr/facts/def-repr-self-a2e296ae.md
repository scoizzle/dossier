# Fact a2e296ae

Store id: 0db615bd-1090-4907-adfb-182dab6f5224

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
- posted_at: `2026-11-09T22:39:41.7427290+00:00`

## Data

```json
{
  "end_line": 1936,
  "entity_kind": "method",
  "parent": "OrderBy",
  "start_line": 1933,
  "symbol": "OrderBy.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1933,"selector":"L1933-L1936","symbol":"OrderBy.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OrderBy.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1936,
    "entity_kind": "method",
    "parent": "OrderBy",
    "start_line": 1933,
    "symbol": "OrderBy.__repr__"
  },
  "id": "0db615bd-1090-4907-adfb-182dab6f5224",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7427290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1933,
        "selector": "L1933-L1936",
        "symbol": "OrderBy.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "e3b7a69a-14ad-4fe4-bc3b-3439c4fe97b7",
  "subject_name": "django/db/models/expressions::OrderBy.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
