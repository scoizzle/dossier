# Fact adc673e9

Store id: 6dbb5d6a-a1cb-4799-9c16-e3e7e5029593

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
- posted_at: `2026-11-09T23:44:50.6173730+00:00`

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
  "id": "6dbb5d6a-a1cb-4799-9c16-e3e7e5029593",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6173730+00:00"
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
  "subject_id": "f03a5f78-5e60-4d63-9aee-3b1309554fa8",
  "subject_name": "django/db/models/fields/files::FieldFile.__bool__",
  "tags": [
    "entity:method"
  ],
  "text": "def __bool__(self)"
}
```
