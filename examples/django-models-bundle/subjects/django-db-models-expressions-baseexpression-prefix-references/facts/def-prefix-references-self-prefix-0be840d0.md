# Fact 0be840d0

Store id: 96408efe-011c-47d1-a5a4-6a73c72300e7

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
- posted_at: `2026-11-09T23:31:55.7897130+00:00`

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
  "id": "96408efe-011c-47d1-a5a4-6a73c72300e7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7897130+00:00"
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
  "subject_id": "1087c170-8089-49ab-aeaf-dd81c3a2dc3c",
  "subject_name": "django/db/models/expressions::BaseExpression.prefix_references",
  "tags": [
    "entity:method"
  ],
  "text": "def prefix_references(self, prefix)"
}
```
