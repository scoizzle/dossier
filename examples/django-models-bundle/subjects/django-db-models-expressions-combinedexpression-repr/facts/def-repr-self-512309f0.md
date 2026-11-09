# Fact 512309f0

Store id: 5408bbd0-9c21-4316-83c4-c5de274903b6

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T22:39:41.5448690+00:00`

## Data

```json
{
  "end_line": 736,
  "entity_kind": "method",
  "parent": "CombinedExpression",
  "start_line": 735,
  "symbol": "CombinedExpression.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":735,"selector":"L735-L736","symbol":"CombinedExpression.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::CombinedExpression.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 736,
    "entity_kind": "method",
    "parent": "CombinedExpression",
    "start_line": 735,
    "symbol": "CombinedExpression.__repr__"
  },
  "id": "5408bbd0-9c21-4316-83c4-c5de274903b6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5448690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 735,
        "selector": "L735-L736",
        "symbol": "CombinedExpression.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "c1596e79-4500-4432-ab26-349756a41f58",
  "subject_name": "django/db/models/expressions::CombinedExpression.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
