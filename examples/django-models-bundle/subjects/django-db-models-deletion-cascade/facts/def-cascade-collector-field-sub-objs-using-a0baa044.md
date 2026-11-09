# Fact a0baa044

Store id: d13d38a3-556e-4e59-ba1f-9f8ccf095bb4

## Text

```text
def CASCADE(collector, field, sub_objs, using)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:48.8985330+00:00`

## Data

```json
{
  "end_line": 31,
  "entity_kind": "function",
  "parent": "deletion",
  "start_line": 22,
  "symbol": "CASCADE"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":22,"selector":"L22-L31","symbol":"CASCADE"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::CASCADE](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 31,
    "entity_kind": "function",
    "parent": "deletion",
    "start_line": 22,
    "symbol": "CASCADE"
  },
  "id": "d13d38a3-556e-4e59-ba1f-9f8ccf095bb4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.8985330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 22,
        "selector": "L22-L31",
        "symbol": "CASCADE"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "9c959ac2-fcfd-42be-bc19-9ab734ae6a9e",
  "subject_name": "django/db/models/deletion::CASCADE",
  "tags": [
    "entity:function"
  ],
  "text": "def CASCADE(collector, field, sub_objs, using)"
}
```
