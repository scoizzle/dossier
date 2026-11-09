# Fact adc673e9

Store id: c8fd45be-991e-48fc-b6c1-77bc572b947f

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
- posted_at: `2026-11-09T22:39:43.1896970+00:00`

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
  "id": "c8fd45be-991e-48fc-b6c1-77bc572b947f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.1896970+00:00"
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
  "subject_id": "0ecb95ec-91ac-46db-95a1-e9fa59e08c99",
  "subject_name": "django/db/models/fields/files::FieldFile.__bool__",
  "tags": [
    "entity:method"
  ],
  "text": "def __bool__(self)"
}
```
