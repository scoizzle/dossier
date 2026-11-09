# Fact b3fe997d

Store id: ff656ae0-ea5d-4945-ad51-8e812fd6fbb9

## Text

```text
class JSONNull(Value)
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
- posted_at: `2026-11-09T22:39:41.6021840+00:00`

## Data

```json
{
  "end_line": 1265,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1244,
  "symbol": "JSONNull"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1244,"selector":"L1244-L1265","symbol":"JSONNull"}`

## Items

```json
[
  {
    "text": "Represent JSON `null` primitive.",
    "locator": {
      "line": 1246
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::JSONNull](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1265,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1244,
    "symbol": "JSONNull"
  },
  "id": "ff656ae0-ea5d-4945-ad51-8e812fd6fbb9",
  "items": [
    {
      "locator": {
        "line": 1246
      },
      "text": "Represent JSON `null` primitive."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6021840+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1244,
        "selector": "L1244-L1265",
        "symbol": "JSONNull"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "f3c9bc7a-f822-42ec-be73-559558dd9922",
  "subject_name": "django/db/models/expressions::JSONNull",
  "tags": [
    "entity:class",
    "decorator:deconstructible"
  ],
  "text": "class JSONNull(Value)"
}
```
