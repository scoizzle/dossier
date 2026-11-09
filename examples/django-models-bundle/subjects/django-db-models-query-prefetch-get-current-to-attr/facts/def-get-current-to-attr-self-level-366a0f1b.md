# Fact 366a0f1b

Store id: 9ae6e586-2f96-4624-b1f0-8577c2aea4ac

## Text

```text
def get_current_to_attr(self, level)
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
- posted_at: `2026-11-09T22:39:49.8543150+00:00`

## Data

```json
{
  "end_line": 2615,
  "entity_kind": "method",
  "parent": "Prefetch",
  "start_line": 2611,
  "symbol": "Prefetch.get_current_to_attr"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2611,"selector":"L2611-L2615","symbol":"Prefetch.get_current_to_attr"}`

## Referenced by

None.

## Subject

[django/db/models/query::Prefetch.get_current_to_attr](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2615,
    "entity_kind": "method",
    "parent": "Prefetch",
    "start_line": 2611,
    "symbol": "Prefetch.get_current_to_attr"
  },
  "id": "9ae6e586-2f96-4624-b1f0-8577c2aea4ac",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.8543150+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2611,
        "selector": "L2611-L2615",
        "symbol": "Prefetch.get_current_to_attr"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "55c99253-0827-4cb2-abb7-ba416e36ad81",
  "subject_name": "django/db/models/query::Prefetch.get_current_to_attr",
  "tags": [
    "entity:method"
  ],
  "text": "def get_current_to_attr(self, level)"
}
```
