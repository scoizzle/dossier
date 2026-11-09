# Fact fe3c302c

Store id: 22633448-3fc8-441f-824a-5556423b85e7

## Text

```text
class When(Expression)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:deconstructible`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.6077130+00:00`

## Data

```json
{
  "end_line": 1713,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1635,
  "symbol": "When"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1635,"selector":"L1635-L1713","symbol":"When"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::When](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1713,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1635,
    "symbol": "When"
  },
  "id": "22633448-3fc8-441f-824a-5556423b85e7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6077130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1635,
        "selector": "L1635-L1713",
        "symbol": "When"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "f5fcdb8d-4f4d-4029-963d-8c573e2aa4ea",
  "subject_name": "django/db/models/expressions::When",
  "tags": [
    "entity:class",
    "decorator:deconstructible"
  ],
  "text": "class When(Expression)"
}
```
