# Fact 0be840d0

Store id: e581b0cc-2221-4c34-8d4a-793c51a32df8

## Text

```text
def prefix_references(self, prefix)
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
- posted_at: `2026-11-09T22:39:41.5278760+00:00`

## Data

```json
{
  "end_line": 458,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 446,
  "symbol": "BaseExpression.prefix_references"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":446,"selector":"L446-L458","symbol":"BaseExpression.prefix_references"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.prefix_references](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 458,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 446,
    "symbol": "BaseExpression.prefix_references"
  },
  "id": "e581b0cc-2221-4c34-8d4a-793c51a32df8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5278760+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 446,
        "selector": "L446-L458",
        "symbol": "BaseExpression.prefix_references"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "c286c275-4634-4884-a856-4e6dd418ce27",
  "subject_name": "django/db/models/expressions::BaseExpression.prefix_references",
  "tags": [
    "entity:method"
  ],
  "text": "def prefix_references(self, prefix)"
}
```
