# Fact bca609d9

Store id: c7e8578a-a5a1-4884-8db4-252ae8c4ff82

## Text

```text
def _disable_cloning(self)
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
- posted_at: `2026-11-09T23:32:04.6269500+00:00`

## Data

```json
{
  "end_line": 2223,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2216,
  "symbol": "QuerySet._disable_cloning"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2216,"selector":"L2216-L2223","symbol":"QuerySet._disable_cloning"}`

## Items

```json
[
  {
    "text": "Prevent calls to _chain() from creating a new QuerySet via _clone(). All subsequent QuerySet mutations will occur on this instance until _enable_cloning() is used.",
    "locator": {
      "line": 2217
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._disable_cloning](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2223,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2216,
    "symbol": "QuerySet._disable_cloning"
  },
  "id": "c7e8578a-a5a1-4884-8db4-252ae8c4ff82",
  "items": [
    {
      "locator": {
        "line": 2217
      },
      "text": "Prevent calls to _chain() from creating a new QuerySet via _clone(). All subsequent QuerySet mutations will occur on this instance until _enable_cloning() is used."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.6269500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2216,
        "selector": "L2216-L2223",
        "symbol": "QuerySet._disable_cloning"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "27328c89-d9a7-4354-97d0-91e52116c803",
  "subject_name": "django/db/models/query::QuerySet._disable_cloning",
  "tags": [
    "entity:method"
  ],
  "text": "def _disable_cloning(self)"
}
```
