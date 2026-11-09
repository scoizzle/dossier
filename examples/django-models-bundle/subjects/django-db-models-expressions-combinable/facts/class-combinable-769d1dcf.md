# Fact 769d1dcf

Store id: 8284eab5-5ccc-498c-9b22-98c0793ae801

## Text

```text
class Combinable
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.4703390+00:00`

## Data

```json
{
  "end_line": 167,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 38,
  "symbol": "Combinable"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":38,"selector":"L38-L167","symbol":"Combinable"}`

## Items

```json
[
  {
    "text": "Provide the ability to combine one or two objects with some connector. For example F('foo') + F('bar').",
    "locator": {
      "line": 39
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 167,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 38,
    "symbol": "Combinable"
  },
  "id": "8284eab5-5ccc-498c-9b22-98c0793ae801",
  "items": [
    {
      "locator": {
        "line": 39
      },
      "text": "Provide the ability to combine one or two objects with some connector. For example F('foo') + F('bar')."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4703390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 38,
        "selector": "L38-L167",
        "symbol": "Combinable"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "1b08241a-3e74-4fd8-a82c-4d85a1981a0f",
  "subject_name": "django/db/models/expressions::Combinable",
  "tags": [
    "entity:class"
  ],
  "text": "class Combinable"
}
```
