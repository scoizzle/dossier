# Fact 72eb1c81

Store id: bbc3b804-7a87-4f34-8395-b67e1aa7a09a

## Text

```text
def _update(self, values, returning_fields=None)
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
- posted_at: `2026-11-09T22:39:49.5352660+00:00`

## Data

```json
{
  "end_line": 1473,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1457,
  "symbol": "QuerySet._update"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1457,"selector":"L1457-L1473","symbol":"QuerySet._update"}`

## Items

```json
[
  {
    "text": "A version of update() that accepts field objects instead of field names. Used primarily for model saving and not intended for use by general code (it requires too much poking around at model internals to be useful at that level).",
    "locator": {
      "line": 1458
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._update](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1473,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1457,
    "symbol": "QuerySet._update"
  },
  "id": "bbc3b804-7a87-4f34-8395-b67e1aa7a09a",
  "items": [
    {
      "locator": {
        "line": 1458
      },
      "text": "A version of update() that accepts field objects instead of field names. Used primarily for model saving and not intended for use by general code (it requires too much poking around at model internals to be useful at that level)."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.5352660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1457,
        "selector": "L1457-L1473",
        "symbol": "QuerySet._update"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "b51c3b51-5d8f-4665-baae-b7d6cd78653c",
  "subject_name": "django/db/models/query::QuerySet._update",
  "tags": [
    "entity:method"
  ],
  "text": "def _update(self, values, returning_fields=None)"
}
```
