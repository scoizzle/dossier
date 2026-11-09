# Fact feb2ce14

Store id: 9e8cd1a2-0b33-4afd-a027-d9bc79bab690

## Text

```text
class Left(Func)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:02.1853430+00:00`

## Data

```json
{
  "end_line": 176,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 154,
  "symbol": "Left"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":154,"selector":"L154-L176","symbol":"Left"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Left](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 176,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 154,
    "symbol": "Left"
  },
  "id": "9e8cd1a2-0b33-4afd-a027-d9bc79bab690",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.1853430+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 154,
        "selector": "L154-L176",
        "symbol": "Left"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "cd44fbff-86cc-4952-8b7b-f78779eb2e34",
  "subject_name": "django/db/models/functions/text::Left",
  "tags": [
    "entity:class"
  ],
  "text": "class Left(Func)"
}
```
