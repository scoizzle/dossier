# Fact 6fff415b

Store id: 9bc19bb7-1ba9-407a-ac2a-e92196a866cc

## Text

```text
def _chain(self)
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
- posted_at: `2026-11-09T22:39:49.7096840+00:00`

## Data

```json
{
  "end_line": 2263,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2247,
  "symbol": "QuerySet._chain"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2247,"selector":"L2247-L2263","symbol":"QuerySet._chain"}`

## Items

```json
[
  {
    "text": "Return a copy of the current QuerySet that's ready for another operation.",
    "locator": {
      "line": 2248
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._chain](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2263,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2247,
    "symbol": "QuerySet._chain"
  },
  "id": "9bc19bb7-1ba9-407a-ac2a-e92196a866cc",
  "items": [
    {
      "locator": {
        "line": 2248
      },
      "text": "Return a copy of the current QuerySet that's ready for another operation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.7096840+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2247,
        "selector": "L2247-L2263",
        "symbol": "QuerySet._chain"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "7ff0f3fc-b67a-45da-b802-ddbd80220b87",
  "subject_name": "django/db/models/query::QuerySet._chain",
  "tags": [
    "entity:method"
  ],
  "text": "def _chain(self)"
}
```
