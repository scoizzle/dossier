# Fact 5c5ca401

Store id: 03d12316-f183-4390-9c1b-0580c26e8bda

## Text

```text
def non_db_attrs(self)
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
- posted_at: `2026-11-09T23:31:58.6660430+00:00`

## Data

```json
{
  "end_line": 610,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 604,
  "symbol": "ForeignObject.non_db_attrs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":604,"selector":"L604-L610","symbol":"ForeignObject.non_db_attrs"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.non_db_attrs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 610,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 604,
    "symbol": "ForeignObject.non_db_attrs"
  },
  "id": "03d12316-f183-4390-9c1b-0580c26e8bda",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6660430+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 604,
        "selector": "L604-L610",
        "symbol": "ForeignObject.non_db_attrs"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "ee4c65da-0d54-496d-9542-4717b3d5f030",
  "subject_name": "django/db/models/fields/related::ForeignObject.non_db_attrs",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def non_db_attrs(self)"
}
```
