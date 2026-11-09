# Fact 8712ba47

Store id: c194448f-bd37-488a-ba56-ffd5a51935d7

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
- posted_at: `2026-11-09T23:44:48.5516790+00:00`

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
  "id": "c194448f-bd37-488a-ba56-ffd5a51935d7",
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
    "posted_at": "2026-11-09T23:44:48.5516790+00:00"
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
  "subject_id": "a713e3e7-8a05-47c6-b6ea-df29ad47a394",
  "subject_name": "django/db/models/base::Model._check_unique_together",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_unique_together(cls)"
}
```
