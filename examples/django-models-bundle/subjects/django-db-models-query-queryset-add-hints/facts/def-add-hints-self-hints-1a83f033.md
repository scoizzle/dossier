# Fact 1a83f033

Store id: 0cd17679-9ff1-4b41-8b33-9534e1805301

## Text

```text
def _add_hints(self, **hints)
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
- posted_at: `2026-11-09T22:39:49.7324530+00:00`

## Data

```json
{
  "end_line": 2336,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2331,
  "symbol": "QuerySet._add_hints"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2331,"selector":"L2331-L2336","symbol":"QuerySet._add_hints"}`

## Items

```json
[
  {
    "text": "Update hinting information for use by routers. Add new key/values or overwrite existing key/values.",
    "locator": {
      "line": 2332
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._add_hints](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2336,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2331,
    "symbol": "QuerySet._add_hints"
  },
  "id": "0cd17679-9ff1-4b41-8b33-9534e1805301",
  "items": [
    {
      "locator": {
        "line": 2332
      },
      "text": "Update hinting information for use by routers. Add new key/values or overwrite existing key/values."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.7324530+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2331,
        "selector": "L2331-L2336",
        "symbol": "QuerySet._add_hints"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "e08e1184-bca7-4ac3-b6bd-b1de4e2f1d18",
  "subject_name": "django/db/models/query::QuerySet._add_hints",
  "tags": [
    "entity:method"
  ],
  "text": "def _add_hints(self, **hints)"
}
```
