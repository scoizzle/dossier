# Fact 2f886b75

Store id: ecd1d14c-1fe6-4b98-ac50-8ddccb94764d

## Text

```text
class F(Combinable)
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
- posted_at: `2026-11-09T23:31:55.8294280+00:00`

## Data

```json
{
  "end_line": 943,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 881,
  "symbol": "F"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":881,"selector":"L881-L943","symbol":"F"}`

## Items

```json
[
  {
    "text": "An object capable of resolving references to existing query objects.",
    "locator": {
      "line": 883
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::F](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 943,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 881,
    "symbol": "F"
  },
  "id": "ecd1d14c-1fe6-4b98-ac50-8ddccb94764d",
  "items": [
    {
      "locator": {
        "line": 883
      },
      "text": "An object capable of resolving references to existing query objects."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8294280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 881,
        "selector": "L881-L943",
        "symbol": "F"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "10f6bc5c-933c-4aec-97af-26e60c07d04c",
  "subject_name": "django/db/models/expressions::F",
  "tags": [
    "entity:class",
    "decorator:deconstructible"
  ],
  "text": "class F(Combinable)"
}
```
