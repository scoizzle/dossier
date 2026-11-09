# Fact 87146d83

Store id: 46a83524-9ccc-4c9a-b2b4-33f06b30565a

## Text

```text
def __rsub__(self, other)
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
- posted_at: `2026-11-09T23:31:55.7437350+00:00`

## Data

```json
{
  "end_line": 137,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 136,
  "symbol": "Combinable.__rsub__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":136,"selector":"L136-L137","symbol":"Combinable.__rsub__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.__rsub__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 137,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 136,
    "symbol": "Combinable.__rsub__"
  },
  "id": "46a83524-9ccc-4c9a-b2b4-33f06b30565a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7437350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 136,
        "selector": "L136-L137",
        "symbol": "Combinable.__rsub__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "a11edd73-1b00-427d-92e8-19149814f652",
  "subject_name": "django/db/models/expressions::Combinable.__rsub__",
  "tags": [
    "entity:method"
  ],
  "text": "def __rsub__(self, other)"
}
```
