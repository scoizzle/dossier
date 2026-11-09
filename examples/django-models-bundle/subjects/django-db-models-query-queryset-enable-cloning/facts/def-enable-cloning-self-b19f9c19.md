# Fact b19f9c19

Store id: 9e8db846-6a75-4578-b3ba-b25f0610f18d

## Text

```text
def _enable_cloning(self)
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
- posted_at: `2026-11-09T22:39:49.7034010+00:00`

## Data

```json
{
  "end_line": 2233,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2225,
  "symbol": "QuerySet._enable_cloning"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2225,"selector":"L2225-L2233","symbol":"QuerySet._enable_cloning"}`

## Items

```json
[
  {
    "text": "Allow calls to _chain() to create a new QuerySet via _clone(). Restores the default behavior where any QuerySet mutation will return a new QuerySet instance. Necessary only when there has been a _disable_cloning() call previously.",
    "locator": {
      "line": 2226
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._enable_cloning](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2233,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2225,
    "symbol": "QuerySet._enable_cloning"
  },
  "id": "9e8db846-6a75-4578-b3ba-b25f0610f18d",
  "items": [
    {
      "locator": {
        "line": 2226
      },
      "text": "Allow calls to _chain() to create a new QuerySet via _clone(). Restores the default behavior where any QuerySet mutation will return a new QuerySet instance. Necessary only when there has been a _disable_cloning() call previously."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.7034010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2225,
        "selector": "L2225-L2233",
        "symbol": "QuerySet._enable_cloning"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "bae27c92-25d0-49e0-bcbc-89ff2968645e",
  "subject_name": "django/db/models/query::QuerySet._enable_cloning",
  "tags": [
    "entity:method"
  ],
  "text": "def _enable_cloning(self)"
}
```
