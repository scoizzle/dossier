# Fact 3b1b628c

Store id: 8c4aee7f-e2ed-4373-b8d0-a52ccec68018

## Text

```text
def formfield(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:43.2761880+00:00`

## Data

```json
{
  "end_line": 541,
  "entity_kind": "method",
  "parent": "ImageField",
  "start_line": 535,
  "symbol": "ImageField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/files.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":535,"selector":"L535-L541","symbol":"ImageField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/files::ImageField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 541,
    "entity_kind": "method",
    "parent": "ImageField",
    "start_line": 535,
    "symbol": "ImageField.formfield"
  },
  "id": "8c4aee7f-e2ed-4373-b8d0-a52ccec68018",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.2761880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 535,
        "selector": "L535-L541",
        "symbol": "ImageField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/files.py"
    }
  ],
  "status": "live",
  "subject_id": "55bd5568-69e8-4c69-af08-5e8ce788bcf2",
  "subject_name": "django/db/models/fields/files::ImageField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
