# Fact bca609d9

Store id: 385a3199-8ef9-4bc7-8656-bce5cffe586a

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
- posted_at: `2026-11-09T23:44:56.1391380+00:00`

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
  "id": "385a3199-8ef9-4bc7-8656-bce5cffe586a",
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
    "posted_at": "2026-11-09T23:44:56.1391380+00:00"
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
  "subject_id": "279a03b5-a437-4ab5-889e-dad49af2cf90",
  "subject_name": "django/db/models/query::QuerySet._disable_cloning",
  "tags": [
    "entity:method"
  ],
  "text": "def _disable_cloning(self)"
}
```
