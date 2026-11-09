# Fact b0bc8074

Store id: 66fc2af3-4ea5-41a3-921c-a4146565b75a

## Text

```text
def db_type(self)
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
- posted_at: `2026-11-09T23:32:00.2689580+00:00`

## Data

```json
{
  "end_line": 129,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 127,
  "symbol": "ForeignObjectRel.db_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":127,"selector":"L127-L129","symbol":"ForeignObjectRel.db_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.db_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 129,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 127,
    "symbol": "ForeignObjectRel.db_type"
  },
  "id": "66fc2af3-4ea5-41a3-921c-a4146565b75a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.2689580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 127,
        "selector": "L127-L129",
        "symbol": "ForeignObjectRel.db_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "15220d14-b7b8-4656-975d-52ecd8c5083a",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.db_type",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def db_type(self)"
}
```
