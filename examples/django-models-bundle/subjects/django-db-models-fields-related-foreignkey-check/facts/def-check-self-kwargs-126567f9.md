# Fact 126567f9

Store id: ebc4fc0b-d758-4d4b-b3d1-a54a7879ff04

## Text

```text
def check(self, **kwargs)
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
- posted_at: `2026-11-09T23:44:51.5682090+00:00`

## Data

```json
{
  "end_line": 1062,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1056,
  "symbol": "ForeignKey.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1056,"selector":"L1056-L1062","symbol":"ForeignKey.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1062,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1056,
    "symbol": "ForeignKey.check"
  },
  "id": "ebc4fc0b-d758-4d4b-b3d1-a54a7879ff04",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5682090+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1056,
        "selector": "L1056-L1062",
        "symbol": "ForeignKey.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "24d4afc9-2465-4f2a-9625-6ac5ad65d77a",
  "subject_name": "django/db/models/fields/related::ForeignKey.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
