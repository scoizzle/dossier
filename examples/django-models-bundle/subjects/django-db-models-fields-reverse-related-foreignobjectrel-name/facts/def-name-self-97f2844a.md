# Fact 97f2844a

Store id: d4d576dc-b0a1-4d33-ad3d-4a07aa2188da

## Text

```text
def name(self)
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
- posted_at: `2026-11-09T23:32:00.2219700+00:00`

## Data

```json
{
  "end_line": 71,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 69,
  "symbol": "ForeignObjectRel.name"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":69,"selector":"L69-L71","symbol":"ForeignObjectRel.name"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.name](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 71,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 69,
    "symbol": "ForeignObjectRel.name"
  },
  "id": "d4d576dc-b0a1-4d33-ad3d-4a07aa2188da",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.2219700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 69,
        "selector": "L69-L71",
        "symbol": "ForeignObjectRel.name"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "d01b52d0-1444-4b66-9607-3a15105c4a76",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.name",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def name(self)"
}
```
