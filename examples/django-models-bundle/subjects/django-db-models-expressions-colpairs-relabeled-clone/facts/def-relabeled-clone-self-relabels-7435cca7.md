# Fact 7435cca7

Store id: a4ad324f-df67-423d-b3e6-f560c5657190

## Text

```text
def relabeled_clone(self, relabels)
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
- posted_at: `2026-11-09T23:31:55.9067420+00:00`

## Data

```json
{
  "end_line": 1438,
  "entity_kind": "method",
  "parent": "ColPairs",
  "start_line": 1435,
  "symbol": "ColPairs.relabeled_clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1435,"selector":"L1435-L1438","symbol":"ColPairs.relabeled_clone"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ColPairs.relabeled_clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1438,
    "entity_kind": "method",
    "parent": "ColPairs",
    "start_line": 1435,
    "symbol": "ColPairs.relabeled_clone"
  },
  "id": "a4ad324f-df67-423d-b3e6-f560c5657190",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9067420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1435,
        "selector": "L1435-L1438",
        "symbol": "ColPairs.relabeled_clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "b13d5270-7dc4-4be5-b92f-13fa77802d26",
  "subject_name": "django/db/models/expressions::ColPairs.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, relabels)"
}
```
