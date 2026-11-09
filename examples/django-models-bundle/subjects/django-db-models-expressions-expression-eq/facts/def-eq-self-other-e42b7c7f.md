# Fact e42b7c7f

Store id: 3e9425b6-44c4-4786-b252-8045f114f7ee

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T22:39:41.5393250+00:00`

## Data

```json
{
  "end_line": 559,
  "entity_kind": "method",
  "parent": "Expression",
  "start_line": 556,
  "symbol": "Expression.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":556,"selector":"L556-L559","symbol":"Expression.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Expression.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 559,
    "entity_kind": "method",
    "parent": "Expression",
    "start_line": 556,
    "symbol": "Expression.__eq__"
  },
  "id": "3e9425b6-44c4-4786-b252-8045f114f7ee",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5393250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 556,
        "selector": "L556-L559",
        "symbol": "Expression.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "6777629c-d0c6-4f05-b22e-7aeaae2b871e",
  "subject_name": "django/db/models/expressions::Expression.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
