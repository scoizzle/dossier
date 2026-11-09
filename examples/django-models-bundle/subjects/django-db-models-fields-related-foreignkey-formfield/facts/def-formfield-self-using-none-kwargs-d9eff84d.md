# Fact d9eff84d

Store id: 283198a8-bdbc-46e1-b13c-09036ee9c240

## Text

```text
def formfield(self, *, using=None, **kwargs)
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
- posted_at: `2026-11-09T23:31:58.7773220+00:00`

## Data

```json
{
  "end_line": 1311,
  "entity_kind": "method",
  "parent": "ForeignKey",
  "start_line": 1296,
  "symbol": "ForeignKey.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1296,"selector":"L1296-L1311","symbol":"ForeignKey.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignKey.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1311,
    "entity_kind": "method",
    "parent": "ForeignKey",
    "start_line": 1296,
    "symbol": "ForeignKey.formfield"
  },
  "id": "283198a8-bdbc-46e1-b13c-09036ee9c240",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.7773220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1296,
        "selector": "L1296-L1311",
        "symbol": "ForeignKey.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "ceddf4d2-5d5c-4467-b77f-c62ea27f8c17",
  "subject_name": "django/db/models/fields/related::ForeignKey.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, *, using=None, **kwargs)"
}
```
