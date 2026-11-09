# Fact 63931e76

Store id: fd72aadd-2062-495f-a2ce-28cbdbaaeafb

## Text

```text
def _merge_sanity_check(self, other)
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
- posted_at: `2026-11-09T22:39:49.7228460+00:00`

## Data

```json
{
  "end_line": 2315,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2305,
  "symbol": "QuerySet._merge_sanity_check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2305,"selector":"L2305-L2315","symbol":"QuerySet._merge_sanity_check"}`

## Items

```json
[
  {
    "text": "Check that two QuerySet classes may be merged.",
    "locator": {
      "line": 2306
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._merge_sanity_check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2315,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2305,
    "symbol": "QuerySet._merge_sanity_check"
  },
  "id": "fd72aadd-2062-495f-a2ce-28cbdbaaeafb",
  "items": [
    {
      "locator": {
        "line": 2306
      },
      "text": "Check that two QuerySet classes may be merged."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.7228460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2305,
        "selector": "L2305-L2315",
        "symbol": "QuerySet._merge_sanity_check"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "a4969c6d-2571-4b4e-a290-9eca072c4bd5",
  "subject_name": "django/db/models/query::QuerySet._merge_sanity_check",
  "tags": [
    "entity:method"
  ],
  "text": "def _merge_sanity_check(self, other)"
}
```
