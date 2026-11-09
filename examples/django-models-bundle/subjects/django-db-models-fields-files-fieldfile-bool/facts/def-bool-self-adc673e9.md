# Fact adc673e9

Store id: 905f34bd-d20c-4182-8d1c-ee51efddb598

## Text

```text
def __bool__(self)
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
- posted_at: `2026-11-09T23:31:57.3440060+00:00`

## Data

```json
{
  "end_line": 38,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 37,
  "symbol": "FieldFile.__bool__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":37,"selector":"L37-L38","symbol":"FieldFile.__bool__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile.__bool__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 38,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 37,
    "symbol": "FieldFile.__bool__"
  },
  "id": "905f34bd-d20c-4182-8d1c-ee51efddb598",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.3440060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 37,
        "selector": "L37-L38",
        "symbol": "FieldFile.__bool__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "2f9d4474-c970-44d0-b7ba-e78eb4a3d3fa",
  "subject_name": "django/db/models/fields/files::FieldFile.__bool__",
  "tags": [
    "entity:method"
  ],
  "text": "def __bool__(self)"
}
```
