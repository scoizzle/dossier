# Fact ce6808b8

Store id: b15a4ae7-72f5-4ed4-8688-78c081c3dc74

## Text

```text
def flatten(self)
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
- posted_at: `2026-11-09T23:44:56.5712590+00:00`

## Data

```json
{
  "end_line": 169,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 156,
  "symbol": "Q.flatten"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":156,"selector":"L156-L169","symbol":"Q.flatten"}`

## Items

```json
[
  {
    "text": "Recursively yield this Q object and all subexpressions, in depth-first order.",
    "locator": {
      "line": 157
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.flatten](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 169,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 156,
    "symbol": "Q.flatten"
  },
  "id": "b15a4ae7-72f5-4ed4-8688-78c081c3dc74",
  "items": [
    {
      "locator": {
        "line": 157
      },
      "text": "Recursively yield this Q object and all subexpressions, in depth-first order."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.5712590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 156,
        "selector": "L156-L169",
        "symbol": "Q.flatten"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "fee45986-1a4b-4229-b5a6-cd6e8e04db1c",
  "subject_name": "django/db/models/query_utils::Q.flatten",
  "tags": [
    "entity:method"
  ],
  "text": "def flatten(self)"
}
```
