# Fact afaf89a6

Store id: ea6333b0-12b3-4533-9fd6-83834c5fdb13

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
- posted_at: `2026-11-09T23:31:55.8478200+00:00`

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
  "id": "ea6333b0-12b3-4533-9fd6-83834c5fdb13",
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
    "posted_at": "2026-11-09T23:31:55.8478200+00:00"
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
  "subject_id": "49e6800a-ad67-4a20-a553-d6c677271c76",
  "subject_name": "django/db/models/expressions::Sliced",
  "tags": [
    "entity:class"
  ],
  "text": "class Sliced(F)"
}
```
