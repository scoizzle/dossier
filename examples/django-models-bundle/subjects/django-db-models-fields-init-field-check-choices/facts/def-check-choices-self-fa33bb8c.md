# Fact fa33bb8c

Store id: 438fe111-4cfc-4793-a6e0-204b88276313

## Text

```text
def _check_choices(self)
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
- posted_at: `2026-11-09T22:39:42.2746220+00:00`

## Data

```json
{
  "end_line": 423,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 350,
  "symbol": "Field._check_choices"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":350,"selector":"L350-L423","symbol":"Field._check_choices"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field._check_choices](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 423,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 350,
    "symbol": "Field._check_choices"
  },
  "id": "438fe111-4cfc-4793-a6e0-204b88276313",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.2746220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 350,
        "selector": "L350-L423",
        "symbol": "Field._check_choices"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "1055ab35-8c59-490c-a71b-62a7e9fe5a03",
  "subject_name": "django/db/models/fields/__init__::Field._check_choices",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_choices(self)"
}
```
