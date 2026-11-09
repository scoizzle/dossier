# Fact 16d7ddcc

Store id: ff36edd6-6fc2-4bcc-9054-048c08394321

## Text

```text
def __setstate__(self, state)
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
- posted_at: `2026-11-09T23:44:50.6406010+00:00`

## Data

```json
{
  "end_line": 156,
  "entity_kind": "method",
  "parent": "FieldFile",
  "start_line": 154,
  "symbol": "FieldFile.__setstate__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":154,"selector":"L154-L156","symbol":"FieldFile.__setstate__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::FieldFile.__setstate__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 156,
    "entity_kind": "method",
    "parent": "FieldFile",
    "start_line": 154,
    "symbol": "FieldFile.__setstate__"
  },
  "id": "ff36edd6-6fc2-4bcc-9054-048c08394321",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.6406010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 154,
        "selector": "L154-L156",
        "symbol": "FieldFile.__setstate__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "b7f42b49-0c4d-4f08-9a63-4eb3a461b351",
  "subject_name": "django/db/models/fields/files::FieldFile.__setstate__",
  "tags": [
    "entity:method"
  ],
  "text": "def __setstate__(self, state)"
}
```
