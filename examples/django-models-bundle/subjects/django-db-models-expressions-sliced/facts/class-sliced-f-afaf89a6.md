# Fact afaf89a6

Store id: 84f1ca1f-0382-4a8a-8bc9-9750aeea19db

## Text

```text
class Sliced(F)
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
- posted_at: `2026-11-09T23:44:49.4990650+00:00`

## Data

```json
{
  "end_line": 1050,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 996,
  "symbol": "Sliced"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":996,"selector":"L996-L1050","symbol":"Sliced"}`

## Items

```json
[
  {
    "text": "An object that contains a slice of an F expression.",
    "locator": {
      "line": 997
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::Sliced](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1050,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 996,
    "symbol": "Sliced"
  },
  "id": "84f1ca1f-0382-4a8a-8bc9-9750aeea19db",
  "items": [
    {
      "locator": {
        "line": 997
      },
      "text": "An object that contains a slice of an F expression."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4990650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 996,
        "selector": "L996-L1050",
        "symbol": "Sliced"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "cfc4e692-118d-4554-b4e1-5c433871d35b",
  "subject_name": "django/db/models/expressions::Sliced",
  "tags": [
    "entity:class"
  ],
  "text": "class Sliced(F)"
}
```
