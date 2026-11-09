# Fact 552a27e2

Store id: 33d5eb53-d0d9-473e-8ff1-e25f37df70bf

## Text

```text
def set_wrapper_classes(self, connection=None)
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
- posted_at: `2026-11-09T23:32:02.9511700+00:00`

## Data

```json
{
  "end_line": 322,
  "entity_kind": "method",
  "parent": "IndexExpression",
  "start_line": 313,
  "symbol": "IndexExpression.set_wrapper_classes"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/indexes.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":313,"selector":"L313-L322","symbol":"IndexExpression.set_wrapper_classes"}`

## Referenced by

None.

## Subject

[django/db/models/indexes::IndexExpression.set_wrapper_classes](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 322,
    "entity_kind": "method",
    "parent": "IndexExpression",
    "start_line": 313,
    "symbol": "IndexExpression.set_wrapper_classes"
  },
  "id": "33d5eb53-d0d9-473e-8ff1-e25f37df70bf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.9511700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 313,
        "selector": "L313-L322",
        "symbol": "IndexExpression.set_wrapper_classes"
      },
      "rel": "derived_from",
      "target": "django/db/models/indexes.py"
    }
  ],
  "status": "live",
  "subject_id": "16cf4290-d04a-447e-a6f6-d2eec57f512e",
  "subject_name": "django/db/models/indexes::IndexExpression.set_wrapper_classes",
  "tags": [
    "entity:method"
  ],
  "text": "def set_wrapper_classes(self, connection=None)"
}
```
