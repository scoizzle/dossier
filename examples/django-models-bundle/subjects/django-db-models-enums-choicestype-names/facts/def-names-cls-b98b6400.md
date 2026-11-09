# Fact b98b6400

Store id: 082f0546-43dd-4a4e-b181-f70e9c4853c4

## Text

```text
def names(cls)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.4973910+00:00`

## Data

```json
{
  "end_line": 38,
  "entity_kind": "method",
  "parent": "ChoicesType",
  "start_line": 35,
  "symbol": "ChoicesType.names"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/enums.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":35,"selector":"L35-L38","symbol":"ChoicesType.names"}`

## Referenced by

None.

## Subject

[django/db/models/enums::ChoicesType.names](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 38,
    "entity_kind": "method",
    "parent": "ChoicesType",
    "start_line": 35,
    "symbol": "ChoicesType.names"
  },
  "id": "082f0546-43dd-4a4e-b181-f70e9c4853c4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.4973910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 35,
        "selector": "L35-L38",
        "symbol": "ChoicesType.names"
      },
      "rel": "derived_from",
      "target": "django/db/models/enums.py"
    }
  ],
  "status": "live",
  "subject_id": "51675a0f-de55-4f3b-8c99-1f406a0fa502",
  "subject_name": "django/db/models/enums::ChoicesType.names",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def names(cls)"
}
```
