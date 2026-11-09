# Fact 51ba8dec

Store id: db4a687b-02cf-4363-96a5-cb9bd84932d4

## Text

```text
def accessor_name(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:45.3546060+00:00`

## Data

```json
{
  "end_line": 212,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 210,
  "symbol": "ForeignObjectRel.accessor_name"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":210,"selector":"L210-L212","symbol":"ForeignObjectRel.accessor_name"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.accessor_name](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 212,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 210,
    "symbol": "ForeignObjectRel.accessor_name"
  },
  "id": "db4a687b-02cf-4363-96a5-cb9bd84932d4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.3546060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 210,
        "selector": "L210-L212",
        "symbol": "ForeignObjectRel.accessor_name"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "a085a3ce-7ac2-444b-82a9-163fa6f96999",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.accessor_name",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def accessor_name(self)"
}
```
