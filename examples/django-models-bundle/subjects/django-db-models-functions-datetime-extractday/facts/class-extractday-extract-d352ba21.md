# Fact d352ba21

Store id: 833c1056-5cdc-430a-bfee-29d06957ac16

## Text

```text
class ExtractDay(Extract)
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
- posted_at: `2026-11-09T22:39:46.1371330+00:00`

## Data

```json
{
  "end_line": 139,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 138,
  "symbol": "ExtractDay"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":138,"selector":"L138-L139","symbol":"ExtractDay"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::ExtractDay](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 139,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 138,
    "symbol": "ExtractDay"
  },
  "id": "833c1056-5cdc-430a-bfee-29d06957ac16",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1371330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 138,
        "selector": "L138-L139",
        "symbol": "ExtractDay"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "70d93f38-869e-4e45-9003-503cec4f4df8",
  "subject_name": "django/db/models/functions/datetime::ExtractDay",
  "tags": [
    "entity:class"
  ],
  "text": "class ExtractDay(Extract)"
}
```
