# Fact 8712ba47

Store id: 476ce330-d2d5-4616-a3e2-855f7de82b81

## Text

```text
def _check_unique_together(cls)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:40.3620000+00:00`

## Data

```json
{
  "end_line": 2193,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 2165,
  "symbol": "Model._check_unique_together"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2165,"selector":"L2165-L2193","symbol":"Model._check_unique_together"}`

## Items

```json
[
  {
    "text": "Check the value of \"unique_together\" option.",
    "locator": {
      "line": 2167
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_unique_together](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2193,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 2165,
    "symbol": "Model._check_unique_together"
  },
  "id": "476ce330-d2d5-4616-a3e2-855f7de82b81",
  "items": [
    {
      "locator": {
        "line": 2167
      },
      "text": "Check the value of \"unique_together\" option."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3620000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2165,
        "selector": "L2165-L2193",
        "symbol": "Model._check_unique_together"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "e7576cc1-2fd4-4baf-bb70-31307b97f38f",
  "subject_name": "django/db/models/base::Model._check_unique_together",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_unique_together(cls)"
}
```
