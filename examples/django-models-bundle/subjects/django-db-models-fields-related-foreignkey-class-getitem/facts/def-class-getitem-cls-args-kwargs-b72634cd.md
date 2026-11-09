# Fact b72634cd

Store id: 09508f79-8809-46e8-a814-7b27a494e4d9

## Text

```text
def __class_getitem__(cls, *args, **kwargs)
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
- posted_at: `2026-11-09T23:44:51.5662930+00:00`

## Data

```json
{
  "end_line": 1054,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1053,
  "symbol": "ForeignKey.__class_getitem__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1053,"selector":"L1053-L1054","symbol":"ForeignKey.__class_getitem__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.__class_getitem__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1054,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1053,
    "symbol": "ForeignKey.__class_getitem__"
  },
  "id": "09508f79-8809-46e8-a814-7b27a494e4d9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5662930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1053,
        "selector": "L1053-L1054",
        "symbol": "ForeignKey.__class_getitem__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "03ea3079-815c-4513-a054-483926ce0eeb",
  "subject_name": "django/db/models/fields/related::ForeignKey.__class_getitem__",
  "tags": [
    "entity:method"
  ],
  "text": "def __class_getitem__(cls, *args, **kwargs)"
}
```
