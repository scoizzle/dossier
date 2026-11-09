# Fact e55c9414

Store id: 6a8d49a2-622b-47f9-925e-7fd1245519f1

## Text

```text
def _clone(self)
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
- posted_at: `2026-11-09T22:39:49.7133920+00:00`

## Data

```json
{
  "end_line": 2283,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2265,
  "symbol": "QuerySet._clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2265,"selector":"L2265-L2283","symbol":"QuerySet._clone"}`

## Items

```json
[
  {
    "text": "Return a copy of the current QuerySet. A lightweight alternative to deepcopy().",
    "locator": {
      "line": 2266
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2283,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2265,
    "symbol": "QuerySet._clone"
  },
  "id": "6a8d49a2-622b-47f9-925e-7fd1245519f1",
  "items": [
    {
      "locator": {
        "line": 2266
      },
      "text": "Return a copy of the current QuerySet. A lightweight alternative to deepcopy()."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.7133920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2265,
        "selector": "L2265-L2283",
        "symbol": "QuerySet._clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "cf9398a7-d34b-48c5-b0b1-7b9c536f8aca",
  "subject_name": "django/db/models/query::QuerySet._clone",
  "tags": [
    "entity:method"
  ],
  "text": "def _clone(self)"
}
```
